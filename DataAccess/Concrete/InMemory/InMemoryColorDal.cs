using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color{Id = 1, ColorName = "Sarı"},
                new Color{Id = 2, ColorName = "Beyaz"},
                new Color{Id = 3, ColorName = "Gri"},
            };
        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color DeleteToColor = _colors.SingleOrDefault(c => c.Id == color.Id);
            _colors.Remove(DeleteToColor);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            Color UpdateToColor = _colors.SingleOrDefault(c => c.Id == color.Id);
            UpdateToColor.ColorName = color.ColorName;
        }
    }
}
