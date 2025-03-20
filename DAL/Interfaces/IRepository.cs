using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    /// <summary>
    /// Интерфейс репозитория.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="Tid">Тип идентификатора, к примеру int или Guid</typeparam>
    public interface IRepository<TEntity,Tid> where TEntity : class
    {
        /// <summary>
        /// Добавление в БД.
        /// </summary>
        /// <param name="entity">Сущность для добавления в БД</param>
        void Add(TEntity entity);

        /// <summary>
        /// Получение из БД сущности  по её идентификатору.
        /// </summary>
        /// <param name="ID">идентификато сущности</param>
        /// <returns>сущность из БД найденая по идентификатору</returns>
        TEntity Get(Tid ID);

        /// <summary>
        /// Получение из БД всех сущностей.
        /// </summary>
        /// <returns>Перечисление всех сущностей из данной таблици в БД</returns>
        IEnumerable<TEntity> Get();

        /// <summary>
        /// Изменение сущности в БД
        /// </summary>
        /// <param name="entity">Сущность с внесенными изменениями, и изменяемая по "id"</param>
        void Edit(TEntity entity);

        /// <summary>
        /// Удаление сущности по "id"
        /// </summary>
        /// <param name="ID">Идентификатор сущности</param>
        void Delete(Tid ID);
    }
}
