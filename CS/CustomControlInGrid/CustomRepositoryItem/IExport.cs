using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomControlInGrid {
    public interface IExport {
        DevExpress.XtraPrinting.IVisualBrick GetBrick(DevExpress.XtraEditors.PrintCellHelperInfo info);
    }
}
