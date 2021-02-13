using System.Windows.Forms;

namespace GameEditor
{
    public partial class GameEditorForm : Form
    {
        public GameEditorForm()
        {
            InitializeComponent();

            gameControl.OnInitialized += GameControl_OnInitialized;
        }

        private void GameControl_OnInitialized(object sender, System.EventArgs e)
        {
            InitializeListsOfTiles();
            groundListView.ItemSelectionChanged += GroundListView_ItemSelectionChanged;
        }

        private void GroundListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            gameControl.CurrentAtlasName = GameControl.GROUND;
            gameControl.CurrentTileName = e.Item.Text;
        }

        private void InitializeListsOfTiles()
        {
            foreach (var tile in gameControl.Atlas[GameControl.GROUND])
            {
                groundListView.Items.Add(tile.Name);
            }
        }
    }
}
