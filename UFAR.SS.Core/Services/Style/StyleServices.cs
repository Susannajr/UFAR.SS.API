using UFAR_SS_Data.DAO;
using UFAR_SS_Data.Entities;

namespace UFAR_SS_Core.Services.Style
{
    /// <summary>
    /// This class implements the 'IStyleService' interface and provides methods for managing items.
    /// Constructor for the 'StyleService' class, injecting the application database context.
    /// </summary>
    public class StyleServices : IStyleServices
    {
        ApplicationDBContext context;
        public StyleServices(ApplicationDBContext _context)
        {
            context = _context;
        }
        /// <summary>
        /// Set default values for style properties. 
        /// Add the style to the database context and save changes.
        /// </summary>
        public StyleEntity AddStyle(StyleEntity style)
        //To do business Logic
        {            
            context.Add(style);
            context.SaveChanges();
            return style;
        }
        /// <summary>
        /// Soft deletes a style from the system. 
        /// Find the style by ID and set the 'isDeleted' flag to 'true'. 
        /// Save changes to the database.
        /// </summary>
        public void RemoveStyle(int styleId)
        {
            context.Styles.FirstOrDefault(x => x.Id == styleId).isDeleted = true;
            context.SaveChanges();
        }
        /// <summary>
        /// Updates an existing style's information. 
        /// Update the style in the database context and save changes.
        /// </summary>
        public void UpdateStyle(StyleEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        /// <summary>
        /// Hard deletes a style from the system. 
        /// Remove the style from the database context and save changes.
        /// </summary>
        public void DeleteStyle(StyleEntity entity) {
            context.Remove(entity);
            context.SaveChanges();
        }
        /// <summary>
        /// Retrieves a list of all styles in the system.
        /// </summary>
        /// <returns> A List of 'StyleEntity' representing all styles in the system.</returns>
        public List<StyleEntity> GetStyles() 
        {
            return context.Styles.ToList();
        }
        /// <summary>
        /// Retrieves a style by its ID. 
        /// Retrieves a style by its name.
        /// </summary>
        /// <returns> An 'StyleEntity' representing the retrieved style. </returns>
        public StyleEntity GetStyleById(int styleId)
        {
            return context.Styles.FirstOrDefault(x=>x.Id == styleId);
        }
        public StyleEntity GetStyleByName(string styleName) {
            return context.Styles.FirstOrDefault(x=>x.Name == styleName);
        }
        /// <summary>
        /// Retrieves a list of all styles in the system.
        /// </summary>
        /// <returns> A List of 'StyleEntity' representing all styles in the system. </returns>
        public List<StyleEntity> GetStyle()
        {
            return context.Styles.ToList();
        }
    }
}
