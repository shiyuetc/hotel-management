
using System;
using System.Collections;

using Dbflute.AllCommon;

namespace Dbflute.AllCommon.Bhv {

    public interface BehaviorWritable : BehaviorReadable {

        /// <summary>
        /// Create entity.
        /// </summary>
        /// <param name="entity">Entity. (NotNull)</param>
        void Create(Entity entity);

        /// <summary>
        /// Modify entity.
        /// </summary>
        /// <param name="entity">Entity. (NotNull)</param>
        /// <exception cref="Dbflute.AllCommon.Exp.EntityAlreadyUpdatedException">When the entity has already been updated by other thread.</exception>
        /// <exception cref="Dbflute.AllCommon.Exp.EntityAlreadyDeletedException">When the entity has already been deleted by other thread.</exception>
        /// <exception cref="Dbflute.AllCommon.Exp.EntityDuplicatedException">When the entity has been duplicated.</exception>
        void Modify(Entity entity);

        /// <summary>
        /// Remove entity.
        /// </summary>
        /// <param name="entity">Entity. (NotNull)</param>
        /// <exception cref="Dbflute.AllCommon.Exp.EntityAlreadyUpdatedException">When the entity has already been updated by other thread.</exception>
        /// <exception cref="Dbflute.AllCommon.Exp.EntityAlreadyDeletedException">When the entity has already been deleted by other thread.</exception>
        /// <exception cref="Dbflute.AllCommon.Exp.EntityDuplicatedException">When the entity has been duplicated.</exception>
        void Remove(Entity entity);
    }
}
