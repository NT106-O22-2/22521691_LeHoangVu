using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                driveTree.Nodes.Add(driveNode);

                // Duyệt tất cả các thư mục trong ổ đĩa
                Directory_Browsing(driveNode, drive.RootDirectory);
            }
        }
        private void Directory_Browsing(TreeNode parentNode, DirectoryInfo directory)
        {
            try
            {
                // Thêm tên thư mục vào treeview
                TreeNode directoryNode = new TreeNode(directory.Name);
                parentNode.Nodes.Add(directoryNode);

                // Duyệt tất cả các file trong thư mục
                foreach (var file in directory.GetFiles())
                {
                    // Thêm tên file vào treeview
                    TreeNode fileNode = new TreeNode(file.Name);
                    directoryNode.Nodes.Add(fileNode);
                }

                // Duyệt tất cả các thư mục con
                foreach (var subdirectory in directory.GetDirectories())
                {
                    Directory_Browsing(directoryNode, subdirectory);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Bỏ qua thư mục không có quyền truy cập
            }
        }
    }
}
