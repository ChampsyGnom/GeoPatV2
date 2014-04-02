using Emash.GeoPat.Layers.Buisness.ViewModels;
using Emash.GeoPat.Layers.Data;
using Emash.GeoPat.Layers.Data.Models;
using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Emash.GeoPat.Applications.Profil.ViewModels
{
    public class SchemaViewModel : PrfBmSchemaViewModel
    {
        private DataContextBase _dbContext;

        public DataContextBase DbContext
        {
            get { return _dbContext; }
            set { 
                _dbContext = value;
                this.ReadPaths();
               
            }
        }

        public void ReadPaths()
        {
            if (_dbContext != null)
            {

                this.PathExe = _dbContext.GetSysUser("DBS_MAIN", "<NULL>", "<NULL>", "<NULL>", "PATH_EXE", null);
                this.PathDocuments = _dbContext.GetSysUser("DBS_MAIN", "<NULL>", "<NULL>", "<NULL>", "PATH_DOC", null);
                String pathCamp = _dbContext.GetSysUser("DBS_MAIN", "<NULL>", "<NULL>", "<NULL>", "PATH_CAMP", null);
                if (pathCamp != null)
                {
                    DirectoryInfo directory = new DirectoryInfo(pathCamp);
                    this.PathDatas = directory.Parent.FullName;
                }
                else this.PathDatas = null;
            }
            this.RaisePropertyChange("PathExe");
            this.RaisePropertyChange("PathDocuments");
            this.RaisePropertyChange("PathDatas");
        }
        public DelegateCommand<System.Windows.Window> ValidateCommand { get; private set; }
        public String PathExe { get; set; }
        public String PathDocuments { get; set; }
        public String PathDatas { get; set; }
        public SchemaViewModel(PrfBmSchema model)
            : base(model)
        {
            this.ValidateCommand = new DelegateCommand<System.Windows.Window>(Validate);

        }

        private void Validate(System.Windows.Window window)
        {
            window.DialogResult = true;
            window.Close();
        }

        
    }
}
