//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EisenhowerMatrix.WPF.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatrixTask
    {
        public int MatrixTaskId { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedUTC { get; set; }
        public int QuadrantId { get; set; }
    
        public virtual Quadrant Quadrant { get; set; }
    }
}
