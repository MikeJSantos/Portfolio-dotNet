using eBookManager.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static eBookManager.Helper.ExtensionMethods;
using static System.Math;

namespace eBookManager
{
    public partial class ImportBooks : Form
    {
        private string _jsonPath;
        private List<StorageSpace> _storageSpaces;
        private enum _storageSpaceSelection { New = -9999, NoSelection = -1 }
        private HashSet<string> AllowedExtensions => new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
        {
            ".doc", ".docx", ".pdf", ".epub", ".lit"
        };
        private enum Extension { doc = 0, docx = 1, pdf = 2, epub = 3, lit = 4 }

        public ImportBooks()
        {
            InitializeComponent();
            _jsonPath = Path.Combine(Application.StartupPath, "bookData.txt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void gbFileDetails_Enter(object sender, EventArgs e)
        {

        }

        private async void ImportBooks_Load(object sender, EventArgs e)
        {
            _storageSpaces = await _storageSpaces.ReadFromDataStore(_jsonPath);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void PopulateBookList(string dirPath, TreeNode treeNode)
        {
            var dirInfo = new DirectoryInfo(dirPath);
            foreach (var subdirInfo in dirInfo.GetDirectories())
            {
                var subdirNode = new TreeNode(subdirInfo.Name)
                {
                    ImageIndex         = 4,
                    SelectedImageIndex = 5
                };

                if (treeNode != null)
                    treeNode.Nodes.Add(subdirNode);
                else
                    tvFoundBooks.Nodes.Add(subdirNode);

                PopulateBookList(dirInfo.FullName, subdirNode);
            }

            var allowedFileInfos = dirInfo.GetFiles().Where(fi => AllowedExtensions.Contains(fi.Extension));
            foreach (var fileInfo in allowedFileInfos)
            {
                var strExtension = fileInfo.Extension.TrimStart('.');
                var iconIndex = Enum.Parse(typeof(Extension), strExtension, true).GetHashCode();

                var fileNode = new TreeNode(fileInfo.Name)
                {
                    Tag                = fileInfo.FullName,
                    ImageIndex         = iconIndex,
                    SelectedImageIndex = iconIndex
                };

                if (treeNode != null)
                    treeNode.Nodes.Add(fileNode);
                else
                    tvFoundBooks.Nodes.Add(fileNode);
            }
        }

        private void BtnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var folderBrowserDialog = new FolderBrowserDialog
                {
                    Description = "Select the location of your eBooks and documents"
                };

                var dialogResult = folderBrowserDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    tvFoundBooks.Nodes.Clear();

                    var dirInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                    var root = new TreeNode(dirInfo.Name)
                    {
                        ImageIndex = 4,
                        SelectedImageIndex = 5
                    };
                    tvFoundBooks.Nodes.Add(root);
                    PopulateBookList(dirInfo.FullName, root);
                    tvFoundBooks.Sort();
                    root.Expand();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TvFoundBooks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var documentEngine = new DocumentEngine();
            var filePath = e.Node.Tag?.ToString() ?? string.Empty;

            if (File.Exists(filePath))
            {
                var (fileName, fileExtension, dateCreated, dateLastAccessed, fileSize, hasError) =
                    documentEngine.GetFileProperties(filePath);

                if (!hasError)
                {
                    tbFileName.Text          = fileName;
                    tbFileExtension.Text     = fileExtension;
                    dtDateCreated.Value      = dateCreated;
                    dtDateLastAccessed.Value = dateLastAccessed;
                    tbPath.Text              = e.Node.Tag.ToString();
                    tbFileSize.Text          = $"{Round(fileSize.ToMegabytes(), 2)} MB";
                }
            }
        }
    }
}
