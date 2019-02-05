using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Windows.Forms;
using Task = System.Threading.Tasks.Task;

namespace CSharpTemplateGenerator
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class AddNewFileCommand
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("f4e5f88e-c5aa-4e14-bfec-635752fae802");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly AsyncPackage package;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNewFileCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private AddNewFileCommand(AsyncPackage package, OleMenuCommandService commandService)
        {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            var menuCommandID = new CommandID(CommandSet, CommandId);
            var menuItem = new MenuCommand(this.Execute, menuCommandID);
            commandService.AddCommand(menuItem);
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static AddNewFileCommand Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in AddNewFileCommand's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            OleMenuCommandService commandService = await package.GetServiceAsync((typeof(IMenuCommandService))) as OleMenuCommandService;
            Instance = new AddNewFileCommand(package, commandService);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void Execute(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            EmptyFileForm form = new EmptyFileForm();
            DTE2 dte2 = (DTE2)Microsoft.VisualStudio.Shell.ServiceProvider.GlobalProvider.GetService(typeof(DTE));
            object[] selectedItems = (object[])dte2.ToolWindows.SolutionExplorer.SelectedItems;
            foreach (UIHierarchyItem selectedUIHierarchyItem in selectedItems)
            {
                if (selectedUIHierarchyItem.Collection.Count > 1)
                {
                    MessageBox.Show("Please select only one project.", "Error");
                } else {
                    Project selectedProject = selectedUIHierarchyItem.Object as Project;
                    if (selectedProject != null)
                    {
                        string pathToAddFileTo = Path.GetDirectoryName(selectedProject.FullName);
                        /*List<string> lines = new List<string>()
                        {
                            "public class Hello",
                            "{",
                            "public static void Main(string[] args)",
                            "{",
                            "Console.WriteLine(\"Hello\");",
                            "Console.ReadLine();",
                            "}",
                            "}"
                        };*/
                        MainFileForm mainForm = new MainFileForm();
                        DialogResult result = mainForm.ShowDialog();
                        result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {

                            


                            string filePath = pathToAddFileTo + form.FileName + ".cs";
                            File.WriteAllLines(filePath, lines);
                            ProjectItems projectItems = selectedProject.ProjectItems;
                            projectItems.AddFromFile(filePath);
                        }
                    }
                }
            }
        }
    }
}
