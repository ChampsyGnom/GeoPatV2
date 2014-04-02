using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Layers.Data
{
    public class DataContextBase : DbContext
    {
        public DataContextBase(DbConnection connection,bool ownConnection)
            : base(connection, ownConnection)
        {
        }

        public void SetSysUser(string codeDbs, String codeTable, String nomUser, string codeColonne, String codePrp, String valPrp)
        {
            if (String.IsNullOrEmpty(valPrp)) return;
            //this.Model.Schema.to

            Type[] types = typeof(DataContextBase).Assembly.GetTypes();
            Type type =  this.GetType();
            String[] camelItems = type.Name.SplitCamelCase();
            String suffix = camelItems[2];
            String sysUserTypeName = suffix + "SysUser";
            Type sysUserType = (from t in types where t.FullName.StartsWith("Emash.GeoPat.Layers.Data.Models.") && t.Name.Equals(sysUserTypeName) select t).FirstOrDefault();

           
            DbSet setSysUser = this.Set(sysUserType);
            ParameterExpression expressionBase = System.Linq.Expressions.Expression.Parameter(setSysUser.ElementType, "item");
            IQueryable queryable = setSysUser.AsQueryable();

            PropertyInfo propCodeDbs = queryable.ElementType.GetProperty("CodeDbs");
            PropertyInfo propCodeTable = queryable.ElementType.GetProperty("CodeTable");
            PropertyInfo propNomUser = queryable.ElementType.GetProperty("NomUser");
            PropertyInfo propCodeColonne = queryable.ElementType.GetProperty("CodeColonne");
            PropertyInfo propCodePrp = queryable.ElementType.GetProperty("CodePrp");
            PropertyInfo propValPrp = queryable.ElementType.GetProperty("ValPrp");

            List<Expression> expressions = new List<Expression>();
            Expression expCodeDbs = System.Linq.Expressions.Expression.Property(expressionBase, "CodeDbs");
            expCodeDbs = Expression.Equal(expCodeDbs, Expression.Constant(codeDbs, typeof(string)));
            expressions.Add(expCodeDbs);

            Expression expCodeTable = System.Linq.Expressions.Expression.Property(expressionBase, "CodeTable");
            expCodeTable = Expression.Equal(expCodeTable, Expression.Constant(codeTable, typeof(string)));
            expressions.Add(expCodeTable);


            Expression expNomUser = System.Linq.Expressions.Expression.Property(expressionBase, "NomUser");
            expNomUser = Expression.Equal(expNomUser, Expression.Constant(nomUser, typeof(string)));
            expressions.Add(expNomUser);


            Expression expCodeColonne = System.Linq.Expressions.Expression.Property(expressionBase, "CodeColonne");
            expCodeColonne = Expression.Equal(expCodeColonne, Expression.Constant(codeColonne, typeof(string)));
            expressions.Add(expCodeColonne);

            Expression expCodePrp = System.Linq.Expressions.Expression.Property(expressionBase, "CodePrp");
            expCodePrp = Expression.Equal(expCodePrp, Expression.Constant(codePrp, typeof(string)));
            expressions.Add(expCodePrp);


            System.Linq.Expressions.Expression expressionAnd = expressions.First();
            for (int i = 1; i < expressions.Count; i++)
            { expressionAnd = System.Linq.Expressions.Expression.And(expressionAnd, expressions[i]); }
            System.Linq.Expressions.MethodCallExpression whereCallExpression = System.Linq.Expressions.Expression.Call(
            typeof(Queryable),
            "Where",
            new Type[] { queryable.ElementType },
            queryable.Expression,
            System.Linq.Expressions.Expression.Lambda(expressionAnd, expressionBase));
            queryable = queryable.Provider.CreateQuery(whereCallExpression);
            Object findedItem = null;
            foreach (Object item in queryable)
            { findedItem = item; }
            if (findedItem == null)
            {
                findedItem = Activator.CreateInstance(queryable.ElementType);
                propCodeDbs.SetValue(findedItem, codeDbs);
                propCodeTable.SetValue(findedItem, codeTable);
                propNomUser.SetValue(findedItem, nomUser);
                propCodeColonne.SetValue(findedItem, codeColonne);
                propCodePrp.SetValue(findedItem, codePrp);
                propValPrp.SetValue(findedItem, valPrp);
                setSysUser.Add(findedItem);

            }
            else
            { propValPrp.SetValue(findedItem, valPrp); }
           
            IEnumerable<DbEntityValidationResult> errors = this.GetValidationErrors();
            if (errors.Count () > 0)
            {throw new Exception("Erreurs : " + errors.First().ToString());}
            this.SaveChanges();
        }

        public String GetSysUser(string codeDbs, String codeTable, String nomUser, string codeColonne, String codePrp, String defaultValue)
        {
            //this.Model.Schema.to

            Type[] types = typeof(DataContextBase).Assembly.GetTypes();
            Type type = this.GetType();
            String[] camelItems = type.Name.SplitCamelCase();
            String suffix = camelItems[2];
            String sysUserTypeName = suffix + "SysUser";
            Type sysUserType = (from t in types where t.FullName.StartsWith("Emash.GeoPat.Layers.Data.Models.") && t.Name.Equals(sysUserTypeName) select t).FirstOrDefault();
            if (sysUserType != null)
            {
                DbSet setSysUser = this.Set(sysUserType);
                ParameterExpression expressionBase = System.Linq.Expressions.Expression.Parameter(setSysUser.ElementType, "item");
                IQueryable queryable = setSysUser.AsQueryable();

                PropertyInfo propCodeDbs = queryable.ElementType.GetProperty("CodeDbs");
                PropertyInfo propCodeTable = queryable.ElementType.GetProperty("CodeTable");
                PropertyInfo propNomUser = queryable.ElementType.GetProperty("NomUser");
                PropertyInfo propCodeColonne = queryable.ElementType.GetProperty("CodeColonne");
                PropertyInfo propCodePrp = queryable.ElementType.GetProperty("CodePrp");
                PropertyInfo propValPrp = queryable.ElementType.GetProperty("ValPrp");

                List<Expression> expressions = new List<Expression>();
                Expression expCodeDbs = System.Linq.Expressions.Expression.Property(expressionBase, "CodeDbs");
                expCodeDbs = Expression.Equal(expCodeDbs, Expression.Constant(codeDbs, typeof(string)));
                expressions.Add(expCodeDbs);

                Expression expCodeTable = System.Linq.Expressions.Expression.Property(expressionBase, "CodeTable");
                expCodeTable = Expression.Equal(expCodeTable, Expression.Constant(codeTable, typeof(string)));
                expressions.Add(expCodeTable);


                Expression expNomUser = System.Linq.Expressions.Expression.Property(expressionBase, "NomUser");
                expNomUser = Expression.Equal(expNomUser, Expression.Constant(nomUser, typeof(string)));
                expressions.Add(expNomUser);


                Expression expCodeColonne = System.Linq.Expressions.Expression.Property(expressionBase, "CodeColonne");
                expCodeColonne = Expression.Equal(expCodeColonne, Expression.Constant(codeColonne, typeof(string)));
                expressions.Add(expCodeColonne);

                Expression expCodePrp = System.Linq.Expressions.Expression.Property(expressionBase, "CodePrp");
                expCodePrp = Expression.Equal(expCodePrp, Expression.Constant(codePrp, typeof(string)));
                expressions.Add(expCodePrp);


                System.Linq.Expressions.Expression expressionAnd = expressions.First();
                for (int i = 1; i < expressions.Count; i++)
                { expressionAnd = System.Linq.Expressions.Expression.And(expressionAnd, expressions[i]); }
                System.Linq.Expressions.MethodCallExpression whereCallExpression = System.Linq.Expressions.Expression.Call(
                typeof(Queryable),
                "Where",
                new Type[] { queryable.ElementType },
                queryable.Expression,
                System.Linq.Expressions.Expression.Lambda(expressionAnd, expressionBase));
                queryable = queryable.Provider.CreateQuery(whereCallExpression);
                Object findedItem = null;
                foreach (Object item in queryable)
                { findedItem = item; }
                if (findedItem != null)
                {
                    Object value = propValPrp.GetValue(findedItem);
                    if (value == null) return defaultValue;
                    else return value.ToString();
                }
                else
                { return null; }
               
            }
            else return null;
         
            
        }
    }
}
