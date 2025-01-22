﻿using AuthService.DAL.Interface;
using AuthService.Entity.Common.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EdgeAuthService.DAL.Repository;

/// <summary>
/// Repository class.
/// </summary>
/// <typeparam name="T">is an object of IRepository.</typeparam>
public class Repository<T> : IRepository<T>
    where T : class
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<Repository<T>> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="Repository{T}"/> class.
    /// </summary>
    /// <param name="unitOfWork">is an object of IUnitOfWork.</param>
    /// <param name="logger">is an object of ILogger.</param>
    public Repository(IUnitOfWork unitOfWork, ILogger<Repository<T>> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    /// <summary>
    /// Method for adding.
    /// </summary>
    /// <param name="entity">is an entity model.</param>
    /// <returns>Returns result.</returns>
    public async Task Add(T entity)
    {
        try
        {
            _logger.LogInformation("Adding:" + entity);
            var savedEntity = _unitOfWork.Context.Set<T>().Add(entity);
            await Task.FromResult(savedEntity.Entity);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }

    /// <summary>
    /// Method for deleting.
    /// </summary>
    /// <param name="entity">is an entity model.</param>
    /// <returns>Returns result.</returns>
    public async Task Delete(T entity)
    {
        try
        {
            _logger.LogInformation("Deleting:" + entity);
            if (entity != null)
            {

                if (entity is IHasSoftDelete softDeleteEntity)
                {
                    softDeleteEntity.IsDeleted = true;
                    softDeleteEntity.UpdatedAt = DateTime.UtcNow;
                    var savedEntity = _unitOfWork.Context.Entry(softDeleteEntity).State = Microsoft.EntityFrameworkCore.EntityState.Modified; // Mark entity as modified   
                    await Task.FromResult(true);
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }

    /// <summary>
    /// Method for getting.
    /// </summary>
    /// <returns>Returns result.</returns>
    public async Task<IEnumerable<T>> Get()
    {
        try
        {
            _logger.LogInformation("Getting list.");
            var entityList = _unitOfWork.Context.Set<T>().ToList();
            return await Task.FromResult(entityList);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }

    /// <summary>
    /// Method for getting single item.
    /// </summary>
    /// <param name="predicate">param check weather.</param>
    /// <returns>Returns result.</returns>
    public async Task<T> GetSingle(Expression<Func<T, bool>> predicate)
    {
        try
        {
            _logger.LogInformation("Getting single:" + predicate);
            var entity = _unitOfWork.Context.Set<T>().FirstOrDefault(predicate);
            return await Task.FromResult(entity);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }

    /// <summary>
    /// Method for getting.
    /// </summary>
    /// <param name="predicate">param check weather.</param>
    /// <returns>Returns result.</returns>
    public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate)
    {
        try
        {
            _logger.LogInformation("Getting:" + predicate);
            var entityList = _unitOfWork.Context.Set<T>().Where(predicate).ToList();
            return await Task.FromResult(entityList);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }

    /// <summary>
    /// Method for updating.
    /// </summary>
    /// <param name="entity">is an entity model.</param>
    /// <returns>Returns result.</returns>
    public async Task Update(T entity)
    {
        try
        {
            _logger.LogInformation("Updating:" + entity);
            var savedEntity = _unitOfWork.Context.Set<T>().Update(entity);
            await Task.FromResult(savedEntity.Entity);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }

    /// <summary>
    /// Method for adding list.
    /// </summary>
    /// <param name="entities">is a list of entity model.</param>
    /// <returns>Returns result.</returns>
    public async Task Add(IEnumerable<T> entities)
    {
        try
        {
            _logger.LogInformation("Adding list." + entities);
            foreach (var entity in entities)
            {
                _unitOfWork.Context.Set<T>().Add(entity);
            }
            await Task.FromResult(entities);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }

    /// <summary>
    /// Method for deleting list.
    /// </summary>
    /// <param name="entities">is a list of entity model.</param>
    /// <returns>Returns result.</returns>
    public async Task Delete(IEnumerable<T> entities)
    {
        try
        {
            _logger.LogInformation("Deleting list." + entities);
            foreach (var entity in entities)
            {
                if (entity is IHasSoftDelete softDeleteEntity)
                {
                    softDeleteEntity.IsDeleted = true;
                    softDeleteEntity.UpdatedAt = DateTime.UtcNow;
                    _unitOfWork.Context.Entry(softDeleteEntity).State = Microsoft.EntityFrameworkCore.EntityState.Modified; // Mark entity as modified
                }
            }

            await Task.FromResult(entities);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }

    /// <summary>
    /// Method for updating list.
    /// </summary>
    /// <param name="entities">is an entity model.</param>
    /// <returns>Returns result.</returns>
    public async Task Update(IEnumerable<T> entities)
    {
        try
        {
            _logger.LogInformation("Updating list." + entities);
            foreach (var entity in entities)
            {
                _unitOfWork.Context.Set<T>().Update(entity);
            }

            await Task.FromResult(entities);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }
    /// <summary>
    /// Discard single item parmanantly
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>

    public async Task Discard(T entity)
    {
        try
        {
            _logger.LogInformation("Deleting permanantly." + entity);

            _unitOfWork.Context.Set<T>().Remove(entity);

            await Task.FromResult(entity);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }
    /// <summary>
    /// Discard list parmanantly
    /// </summary>
    /// <param name="entities"></param>
    /// <returns></returns>

    public async Task Discard(IEnumerable<T> entities)
    {
        try
        {
            _logger.LogInformation("Deleting list permanantly." + entities);
            foreach (var entity in entities)
            {
                _unitOfWork.Context.Set<T>().Remove(entity);
            }

            await Task.FromResult(entities);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, ex.InnerException, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            throw new Exception(ex.Message, ex.InnerException);
        }
    }

    public IQueryable<T> GetAllReadOnly()
    {
        return _unitOfWork.Context.Set<T>().AsNoTracking();
    }

}
