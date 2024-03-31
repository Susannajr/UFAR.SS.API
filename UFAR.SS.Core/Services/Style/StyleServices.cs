using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UFAR.SS.Core.Services.Style;
using UFAR.SS.Data.DAO;
using UFAR.SS.Data.Entities;

namespace UFAR.SS.Core.Services.Style
{
    internal class StyleServices : IStyleServices
    {
        ApplicationDBContext context;
        public StyleServices(ApplicationDBContext _context)
        {
            context = _context;
        }
        public void AddStyle(StyleEntity style)
        //To do business Logic
        {
            style.Name = "Name";
            
            context.Add(style);
            context.SaveChanges();
        }
        //Soft Delete
        public void RemoveStyle(int styleId)
        {
            context.Styles.FirstOrDefault(x => x.Id == styleId).isDeleted = true;
            context.SaveChanges();
        }
        public void UpdateStyle(StyleEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        //Hard Delete
        public void DeleteStyle(StyleEntity entity) {
            context.Remove(entity);
            context.SaveChanges();
        }
        public List<StyleEntity> GetStyles() {
            return context.Styles.ToList();
        }
        public StyleEntity GetStyleById(int styleId)
        {
            return context.Styles.FirstOrDefault(x=>x.Id == styleId);
        }
        public StyleEntity GetStyleByName(string styleName) {
            return context.Styles.FirstOrDefault(x=>x.Name == styleName);
        }

        public List<StyleEntity> GetStyle()
        {
            throw new NotImplementedException();
        }
    }
}
