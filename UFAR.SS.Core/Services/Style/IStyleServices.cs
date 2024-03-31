using UFAR.SS.Data.Entities;

namespace UFAR.SS.Core.Services.Style
{
    public interface IStyleServices
    {
        void AddStyle(StyleEntity style);
        void RemoveStyle(int styleId);
        void UpdateStyle(StyleEntity style);
        void DeleteStyle(StyleEntity style);
        List<StyleEntity> GetStyle();
        StyleEntity GetStyleById(int styleid);
        StyleEntity GetStyleByName(string styleName);
    }
}