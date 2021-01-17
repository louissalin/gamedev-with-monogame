using Engine2D.Input;

namespace Game.Input
{
    public class DevInputCommand : BaseInputCommand 
    {
        // Out of Game Commands
        public class DevQuit : DevInputCommand { }
        public class DevExplode : DevInputCommand { }
        public class DevMissileExplode : DevInputCommand { }
        public class DevBulletSparks : DevInputCommand { }
        public class DevNotMoving : DevInputCommand { }
        public class DevShoot : DevInputCommand { }

        public class DevCamLeft : DevInputCommand { }
        public class DevCamRight : DevInputCommand { }
        public class DevCamUp : DevInputCommand { }
        public class DevCamDown : DevInputCommand { }
        public class DevCamRotateLeft : DevInputCommand { }
        public class DevCamRotateRight : DevInputCommand { }
    }
}
