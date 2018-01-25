using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using FlexApp.Lib.Constants;
using FlexApp.Lib.Entity;
using FlexApp.Lib.Helpers;
using FlexApp.Lib.Interfaces.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FlexApp.BaseRepository
{
    public abstract class BaseDa<TContext, TEntity> : IBaseDa<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        private readonly string _connectionString;
        protected BaseDa(string connectionString)
        {
            _connectionString = connectionString;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int Add(TEntity entity)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Add(entity);
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual int Add(IList<TEntity> entities)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.AddRange(entities);
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<int> AddAsync(TEntity entity)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Add(entity);
                return await context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<int> AddAsync(IList<TEntity> entities)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.AddRange(entities);
                return await context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int AddOrUpdate(TEntity entity)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                dbSet.AddOrUpdate(entity);
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual int AddOrUpdate(IList<TEntity> entities)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                foreach (var entity in entities)
                {
                    dbSet.Attach(entity);
                    dbSet.AddOrUpdate(entity);
                }
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<int> AddOrUpdateAsync(TEntity entity)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                dbSet.AddOrUpdate(entity);
                return await context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<int> AddOrUpdateAsync(IList<TEntity> entities)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                foreach (var entity in entities)
                {
                    dbSet.Attach(entity);
                    dbSet.AddOrUpdate(entity);
                }
                return await context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int Update(TEntity entity)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual int Update(IList<TEntity> entities)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                foreach (var entity in entities)
                {
                    dbSet.Attach(entity);
                    context.Entry(entity).State = EntityState.Modified;
                }
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<int> UpdateAsync(TEntity entity)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                return await context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<int> UpdateAsync(IList<TEntity> entities)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                foreach (var entity in entities)
                {
                    dbSet.Attach(entity);
                    context.Entry(entity).State = EntityState.Modified;
                }
                return await context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int Delete(TEntity entity)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                dbSet.Remove(entity);
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual int Delete(IList<TEntity> entities)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                foreach (var entity in entities)
                {
                    dbSet.Attach(entity);
                }
                dbSet.RemoveRange(entities);
                return context.SaveChanges();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<int> DeleteAsync(TEntity entity)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                dbSet.Remove(entity);
                return await context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<int> DeleteAsync(IList<TEntity> entities)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                foreach (var entity in entities)
                {
                    dbSet.Attach(entity);
                }
                dbSet.RemoveRange(entities);
                return await context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity GetById(params object[] id)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.Find(id);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<TEntity> GetByIdAsync(params object[] id)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.FindAsync(id);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IList<TEntity> GetAll()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<TEntity>> GetAllAsync()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.ToListAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual TEntity Single()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.SingleOrDefault();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual TEntity Single(Func<TEntity, bool> predicate)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.SingleOrDefault(predicate);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual async Task<TEntity> SingleAsync()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.SingleOrDefaultAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.SingleOrDefaultAsync(predicate);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual TEntity First()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.FirstOrDefault();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual TEntity First(Func<TEntity, bool> predicate)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.FirstOrDefault(predicate);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual async Task<TEntity> FirstAsync()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.FirstOrDefaultAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.FirstOrDefaultAsync(predicate);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual int Count()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.Count();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual int Count(Func<TEntity, bool> predicate)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.Count(predicate);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual async Task<int> CountAsync()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.CountAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.CountAsync(predicate);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual long LongCount()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.LongCount();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual long LongCount(Func<TEntity, bool> predicate)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.LongCount(predicate);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual async Task<long> LongCountAsync()
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.LongCountAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return await dbSet.LongCountAsync(predicate);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IList<TEntity> Where(Func<TEntity, bool> predicate)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                return dbSet.Where(predicate).ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual int ExecuteSqlCommand(string sqlCommand, params object[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                return context.Database.ExecuteSqlCommand(sqlCommand, parameters);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual async Task<int> ExecuteSqlCommandAsync(string sqlCommand, params object[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                return await context.Database.ExecuteSqlCommandAsync(sqlCommand, parameters);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual IList<TEntity> ExecuteSqlQuery(string sqlCommand, params object[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                return context.Database.SqlQuery<TEntity>(sqlCommand, parameters).ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual async Task<IList<TEntity>> ExecuteSqlQueryAsync(string sqlCommand, params object[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                return await context.Database.SqlQuery<TEntity>(sqlCommand, parameters).ToListAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual int ExecuteStoreCommand(string sqlCommand, params object[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                IDbCommand storeCommand = context.Database.Connection.CreateCommand();
                storeCommand.CommandText = sqlCommand;
                storeCommand.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        storeCommand.Parameters.Add(parameter);
                    }
                }
                return storeCommand.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual IList<TEntity> ExecuteStoreQuery(string sqlCommand, params object[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                IDbCommand storeQuery = context.Database.Connection.CreateCommand();
                storeQuery.CommandText = sqlCommand;
                storeQuery.CommandType = CommandType.StoredProcedure;
                if (parameters.Length > 0)
                {
                    foreach (var parameter in parameters)
                    {
                        storeQuery.Parameters.Add(parameter);
                    }
                }
                var entities = Activator.CreateInstance<IList<TEntity>>();
                using (IDataReader reader = storeQuery.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var entity = Activator.CreateInstance<TEntity>();
                        foreach (var prop in entity.GetType().GetProperties().Where(prop => !Equals(reader[prop.Name], DBNull.Value)))
                        {
                            prop.SetValue(entity, reader[prop.Name], null);
                        }
                        entities.Add(entity);
                    }
                }
                return entities;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="entity"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual TEntity LoadRelatedEntity<TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> predicate) where TProperty : class
        {
            using (var context = Activator.CreateInstance<TContext>())
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                context.Entry(entity).Reference(predicate).Load();
                return entity;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="entity"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual TEntity LoadRelatedEntity<TProperty>(TEntity entity, Expression<Func<TEntity, ICollection<TProperty>>> predicate) where TProperty : class
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                context.Entry(entity).Collection(predicate).Load();
                return entity;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="entity"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<TEntity> LoadRelatedEntityAsync<TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> predicate) where TProperty : class
        {
            using (var context = Activator.CreateInstance<TContext>())
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                await context.Entry(entity).Reference(predicate).LoadAsync();
                return entity;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="entity"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<TEntity> LoadRelatedEntityAsync<TProperty>(TEntity entity, Expression<Func<TEntity, ICollection<TProperty>>> predicate) where TProperty : class
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                await context.Entry(entity).Collection(predicate).LoadAsync();
                return entity;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual TEntity LoadRelatedEntity(TEntity entity, params string[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                var props = entity.GetType().GetProperties().Where(prop => parameters.Contains(prop.Name));
                var collectionType = typeof(ICollection<>);
                foreach (var prop in props)
                {
                    var propType = prop.GetType();
                    if (propType.IsGenericType && collectionType.IsAssignableFrom(propType.GetGenericTypeDefinition()) ||
                        propType.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == collectionType))
                    {
                        context.Entry(entity).Collection(prop.Name).Load();
                    }
                    else
                    {
                        context.Entry(entity).Reference(prop.Name).Load();
                    }
                }
                return entity;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual TEntity LoadRelatedEntity(Func<TEntity, bool> predicate, params string[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                var entity = dbSet.SingleOrDefault(predicate);
                if (entity == null) return null;
                var props = entity.GetType().GetProperties().Where(prop => parameters.Contains(prop.Name));
                var collectionType = typeof(ICollection<>);
                foreach (var prop in props)
                {
                    var propType = prop.PropertyType;
                    if (propType.IsGenericType && propType.GetGenericTypeDefinition() == collectionType)
                    {
                        context.Entry(entity).Collection(prop.Name).Load();
                    }
                    else
                    {
                        context.Entry(entity).Reference(prop.Name).Load();
                    }
                }
                return entity;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual async Task<TEntity> LoadRelatedEntityAsync(TEntity entity, params string[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                dbSet.Attach(entity);
                var props = entity.GetType().GetProperties().Where(prop => parameters.Contains(prop.Name));
                var collectionType = typeof(ICollection<>);
                foreach (var prop in props)
                {
                    var propType = prop.GetType();
                    if (propType.IsGenericType && collectionType.IsAssignableFrom(propType.GetGenericTypeDefinition()) ||
                        propType.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == collectionType))
                    {
                        await context.Entry(entity).Collection(prop.Name).LoadAsync();
                    }
                    else
                    {
                        await context.Entry(entity).Reference(prop.Name).LoadAsync();
                    }
                }
                return entity;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual async Task<TEntity> LoadRelatedEntityAsync(Func<TEntity, bool> predicate, params string[] parameters)
        {
            using (var context = (TContext)Activator.CreateInstance(typeof(TContext), _connectionString))
            {
                var dbSet = context.Set<TEntity>();
                var entity = dbSet.SingleOrDefault(predicate);
                if (entity == null) return null;
                var props = entity.GetType().GetProperties().Where(prop => parameters.Contains(prop.Name));
                var collectionType = typeof(ICollection<>);
                foreach (var prop in props)
                {
                    var propType = prop.PropertyType;
                    if (propType.IsGenericType && propType.GetGenericTypeDefinition() == collectionType)
                    {
                        await context.Entry(entity).Collection(prop.Name).LoadAsync();
                    }
                    else
                    {
                        await context.Entry(entity).Reference(prop.Name).LoadAsync();
                    }
                }
                return entity;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void SetAuditField(object entity)
        {
            var userId = CurrentUserId;
            var type = entity.GetType();
            var objId = Identification(entity, type);
            if (objId == 0)
            {
                SetValue(entity, userId, type, Constant.AuditCreatedBy);
                SetValue(entity, DateTime.Now, type, Constant.AuditCreatedDate);
            }
            SetValue(entity, userId, type, Constant.AuditUpdatedBy);
            SetValue(entity, DateTime.Now, type, Constant.AuditUpdatedDate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Identification(object entity)
        {
            var type = entity.GetType();
            var prop = type.GetProperty("Id");
            return (long)prop.GetValue(entity);
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual long CurrentUserId
        {
            get
            {
                try
                {
                    return CurrentUserData.Id;
                }
                catch
                {
                    //LogHelper.Log(ex.Message,ex);
                    return 0;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual UserData CurrentUserData
        {
            get
            {
                var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
                if (HttpContext.Current.User.Identity.IsAuthenticated && authCookie != null)
                {

                    var authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                    if (authTicket != null)
                    {
                        var userData = JsonConvert.DeserializeObject<UserData>(authTicket.UserData);
                        return userData;
                    }
                }
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual RoleData CurrentUserRole
        {
            get
            {
                try
                {
                    return CurrentUserData.FlexRole;
                }
                catch (Exception ex)
                {
                    LogHelper.Log(ex.Message, ex);
                    return null;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="propertyName"></param>
        private static void SetValue(object entity, object value, Type type, string propertyName)
        {
            var prop = type.GetProperty(propertyName);
            prop.SetValue(entity, value, null);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private static long Identification(object entity, Type type)
        {
            var prop = type.GetProperty("Id");
            return (long)prop.GetValue(entity);
        }
    }
}
