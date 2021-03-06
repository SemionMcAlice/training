﻿using ActiveCommerce.Training.CartPersistence.Common;

namespace ActiveCommerce.Training.CartPersistence.Pipelines.Mvc
{
    public class LoadShoppingCart : Analytics.LoadShoppingCart
    {
        protected override bool PersistenceActive()
        {
            return CartPersistenceContext.IsActive;
        }
    }
}
