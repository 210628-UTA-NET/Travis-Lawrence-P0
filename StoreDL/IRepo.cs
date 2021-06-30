using System.Collections.Generic;

namespace StoreDL
{
    /// <summary>
    /// Handles accessing of databases
    /// </summary>
    /// <typeparam name="T">Inherited classes will handle different class types</typeparam>
    public interface IRepo<T>
    {
        /// <summary>
        /// Retrieve all object entries currently in the database
        /// </summary>
        /// <returns>Returns a list of all current entries</returns>
        List<T> GetAllData();
        /// <summary>
        /// Essentially checks whether a particular object is in the database.
        /// </summary>
        /// <param name="p_entry">An object with parameters identical to what the method is searching for</param>
        /// <returns>Returns the matching entry when it is found</returns>
        T GetData(T p_entry);
        /// <summary>
        /// Adds a new object to the database
        /// </summary>
        /// <param name="p_entry">The object which will be added</param>
        /// <returns>Returns the newly added object</returns>
        T AddData(T p_entry);
    }
}
