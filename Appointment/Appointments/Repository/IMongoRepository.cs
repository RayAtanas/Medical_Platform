using Appointments.Entity;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Appointments.Repository
{
   
        internal interface IMongoRepository
        {
            void SeedData<T>(IMongoCollection<T> collection) where T : BaseEntity;


            Task CreateAsync<T>(T collection) where T : BaseEntity;

            Task<T> FindAsync<T>(Expression<Func<T, bool>> funcExpression)
                where T : BaseEntity;

            Task<K> FindAsync<T, K>(
                Expression<Func<T, IEnumerable<K>>> fields,
                Expression<Func<K, bool>> funcExpression,
                Expression<Func<T, K>> expression)
                where T : BaseEntity
                where K : BaseEntity;

            Task<IEnumerable<T>> FindAllAsync<T>(Expression<Func<T, bool>> funcExpression) where T : BaseEntity;

            Task<IEnumerable<T>> FindAllAsync<T>(Expression<Func<T, bool>> funcExpression, ProjectionDefinition<T> FieldsToExclude) where T : BaseEntity;

            Task<bool> UpdateAsync<T>(T collection) where T : BaseEntity;

            Task<bool> UpdateAsync<T, K>(
                Expression<Func<T, bool>> funcExpression,
                Expression<Func<T, K>> updateExpression,
                K objToUpdate)
                where T : BaseEntity;

            Task<long> Count<T>(Expression<Func<T, bool>> funcExpression) where T : BaseEntity;
        }

    }

