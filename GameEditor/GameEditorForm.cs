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

            comboLevelNb.SelectedIndex = 0;
        }

        private void GameControl_OnInitialized(object sender, System.EventArgs e)
        {
            InitializeListsOfTiles();

            groundListView.ItemSelectionChanged += GroundListView_ItemSelectionChanged;
            buildingsListView.ItemSelectionChanged += BuildingsListView_ItemSelectionChanged;
            objectsListView.ItemSelectionChanged += ObjectsListView_ItemSelectionChanged;

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

        private void BuildingsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            gameControl.CurrentTileName = e.Item.Text;
        }

        private void ObjectsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            gameControl.CurrentTileName = e.Item.Text;
        }

        private void InitializeListsOfTiles()
        {
            foreach (var tile in gameControl.Atlas[GameControl.GROUND])
            {
                groundListView.Items.Add(tile.Name);
            }

            foreach (var tile in gameControl.Atlas[GameControl.BUILDINGS])
            {
                buildingsListView.Items.Add(tile.Name);
            }

            foreach (var gameObject in gameControl.GameObjects)
            {
                objectsListView.Items.Add(gameObject.Key);
            }
        }

        private void buttonLoad_Click(object sender, System.EventArgs e)
        {
            gameControl.LoadLevel();
        }

        private void buttonSave_Click_1(object sender, System.EventArgs e)
        {
            gameControl.SaveCurrentLevel();
        }

        private void comboLevelNb_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            gameControl.CurrentLevel = comboLevelNb.SelectedIndex + 1;
        }
    }
}
