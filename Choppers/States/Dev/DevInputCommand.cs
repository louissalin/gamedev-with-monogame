﻿using Choppers.Engine.Input;

namespace Choppers.Input
{
    public class DevInputCommand : BaseInputCommand 
    {
        // Out of Game Commands
        public class DevQuit : DevInputCommand { }
        public class DevExplode : DevInputCommand { }
        public class DevMissileExplode : DevInputCommand { }
        public class DevBulletSparks : DevInputCommand { }
        public class DevLeft : DevInputCommand { }
        public class DevRight : DevInputCommand { }
        public class DevNotMoving : DevInputCommand { }
        public class DevShoot : DevInputCommand { }
    }
}
