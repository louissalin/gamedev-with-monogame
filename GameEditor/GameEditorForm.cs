using System.Windows.Forms;

namespace GameEditor
{
    public partial class GameEditorForm : Form
    {
        public GameEditorForm()
        {
            InitializeComponent();

            gameControl.ClientSize = new System.Drawing.Size(1280, 720);
            gameControl.OnInitialized += GameControl_OnInitialized;
            buttonSave.Click += ButtonSave_Click;

            comboLevelNb.SelectedIndex = 0;
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            gameControl.SaveCurrentLevel();
        }

        private void GameControl_OnInitialized(object sender, System.EventArgs e)
        {
            InitializeListsOfTiles();
            groundListView.ItemSelectionChanged += GroundListView_ItemSelectionChanged;
            objectTabControl.SelectedIndexChanged += ObjectTabControl_SelectedIndexChanged;
        }

        private void ObjectTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            gameControl.CurrentAtlasName = objectTabControl.SelectedTab.Text;
            gameControl.CurrentTileName = null;
        }

        private void GroundListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            gameControl.CurrentTileName = e.Item.Text;
        }

        private void InitializeListsOfTiles()
        {
            foreach (var tile in gameControl.Atlas[GameControl.GROUND])
            {
                groundListView.Items.Add(tile.Name);
            }
        }

        private void buttonLoad_Click(object sender, System.EventArgs e)
        {
            gameControl.LoadLevel();
        }
    }
}
