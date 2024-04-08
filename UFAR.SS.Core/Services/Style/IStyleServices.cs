using UFAR_SS_Data.Entities;

///<summary>
///The interface defines methods for managing styles.
///Sequentially it adds a new style to the system.
///Removes a style from the system by ID.
///Updates an existing style's information.
///Deletes a style from the system.
///Retrieves a list of all styles in the system.
///Retrieves a style by its ID.
///Retrieves a style by its name.
/// </summary>

namespace UFAR_SS_Core.Services.Style
{
    public interface IStyleServices
    {
        StyleEntity AddStyle(StyleEntity style);
        void RemoveStyle(int styleId);
        void UpdateStyle(StyleEntity style);
        void DeleteStyle(StyleEntity style);
        List<StyleEntity> GetStyle();
        StyleEntity GetStyleById(int styleid);
        StyleEntity GetStyleByName(string styleName);
    }
}