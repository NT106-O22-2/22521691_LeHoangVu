using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_22521691
{
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
        }

        private void Task7_Load(object sender, EventArgs e)
        {
            // Duyệt tất cả các ổ đĩa
            foreach (var drive in DriveInfo.GetDrives())
            {
                // Thêm tên ổ đĩa vào treeview
                TreeNode driveNode = new TreeNode(drive.Name);
                driveNode.Nodes.Add("");
                driveNode.Tag = drive.RootDirectory;
                
                driveTree.Nodes.Add(driveNode);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Close();
            }
        }

        private void driveTree_BeforeExpand(object sender, TreeViewCancelEventArgs tree)
        {
            if (tree.Node.Nodes.Count == 1)
            {
                try
                {
                    //Tìm các folder
                    DirectoryInfo direc = (DirectoryInfo)tree.Node.Tag;
                    DirectoryInfo[] childDirec = direc.GetDirectories();
                    for (int i = 0; i < childDirec.Length; i++)
                    {
                        DirectoryInfo subDirectory = childDirec[i];

                        // Tạo đối tượng TreeNode cho thư mục con
                        TreeNode directoryNode = new TreeNode(subDirectory.Name);
                        directoryNode.Nodes.Add("");
                        directoryNode.Tag = subDirectory;
                        
                        tree.Node.Nodes.Add(directoryNode);
                    }

                    // Lấy danh sách các file
                    FileInfo[] files = direc.GetFiles();
                    for (int i = 0; i < files.Length; i++)
                    {
                        FileInfo file = files[i];

                        TreeNode fileNode = new TreeNode(file.Name);
                        fileNode.Tag = file;
                        tree.Node.Nodes.Add(fileNode);
                    }
                } catch
                {
                    tree.Node.Nodes.Add(new TreeNode("Không thể truy cập!!!"));
                }
            }
        }

        private void driveTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs tree)
        {
            if (tree.Node.Tag is DirectoryInfo)
            {
                // Điều hướng đến thư mục tiếp theo
                driveTree.SelectedNode = tree.Node;

                if (!tree.Node.IsExpanded) 
                    tree.Node.Expand();
                else if (tree.Node.IsExpanded) 
                    tree.Node.Collapse();
            }
            else if (tree.Node.Tag is FileInfo file)
            {
                file = (FileInfo)tree.Node.Tag;
                string fileOpen = file.Extension.ToLower();

                if (fileOpen == ".jpg" || fileOpen == ".png")
                {
                    label.Hide();
                    using (WebClient client = new WebClient())
                    {
                        byte[] imageBytes = client.DownloadData(file.FullName);
                        using (MemoryStream stream = new MemoryStream(imageBytes))
                        {
                            Image image = Image.FromStream(stream);
                            // Hiển thị ảnh
                            ptBox.Image = image;
                        }
                    }
                } else if (fileOpen == ".txt")
                {
                    ptBox.Image = null;
                    label.Text = File.ReadAllText(file.FullName);
                    label.BackColor = Color.LightGray;
                }
            }
        }

        
    }
}
