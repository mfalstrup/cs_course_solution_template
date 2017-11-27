using System;

namespace Mod10Interface
{
    class LastBil : IMaskine
    {
        void IMaskine.Start()
        {
            throw new NotImplementedException();
        }

        int IMaskine.Status(bool v)
        {
            throw new NotImplementedException();
        }

        void IMaskine.Stop()
        {
            throw new NotImplementedException();
        }
    }
}
