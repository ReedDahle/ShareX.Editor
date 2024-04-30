using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareX.ScreenCaptureLib.Shapes // RCD 4-30-24
{
    public class FloodFillEventArgs : EventArgs
    {
        public FloodFillEventArgs() { }
    }
    
    public class FloodFillShape : BaseShape
    {
        public delegate void FloodFillHandler(object? sender, FloodFillEventArgs e);

        public static event FloodFillHandler UndoFloodFill;

        public override ShapeCategory ShapeCategory => ShapeCategory.FloodFill;

        public override ShapeType ShapeType => ShapeType.FloodFill;

        public FloodFillShape() { }

        public override void Dispose()
        {
            UndoFloodFill?.Invoke(this, new());
        }

        public override bool IsSelectable => false;
    }
}
