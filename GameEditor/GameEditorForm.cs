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
        }

        private void InitializeListsOfTiles()
        {
            foreach (var tile in gameControl.GroundAtlas)
            {
                groundListView.Items.Add(tile.Name);
            }
        }
    }
}
