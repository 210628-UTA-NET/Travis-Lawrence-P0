﻿using System.Collections.Generic;

namespace StoreBL
{
    /// <summary>
    /// Handles all business logic for StoreModels
    /// </summary>
    /// <typeparam name="T">Type of StoreModel a child class will handle</typeparam>
    public interface IBL<T>{
        /// <summary>
        /// Retrieves all data from the database
        /// </summary>
        /// <returns>Returns a list of all objects within a model's database</returns>
        List<T> GetAllData();
        /// <summary>
        /// Searches a database and retrieves an object with a corresponding parameter to the input. Will be overloaded according to each child class.
        /// </summary>
        /// <returns>Returns the object if it is found</returns>
        T GetData();
        /// <summary>
        /// Adds a new object to the database.
        /// </summary>
        /// <param name="p_entry">The new object to be added</param>
        /// <returns>Returns the newly added object</returns>
        T AddData(T p_entry);
    }
}