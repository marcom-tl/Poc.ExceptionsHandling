﻿using LanguageExt.Common;
using Poc.ExceptionsHandling.Host.Domain;

namespace Poc.ExceptionsHandling.Host.Validations
{
    public class ProductValidatorWithException:IProductValidator
    {

        public async Task<Result<string>> ValidateAsync(Product product)
        {
            if (!Consts.ValidCategories.Contains(product.Category))
                throw new ProductValidationException($"Unknown Category:{product.Category}");
            return new Result<string>("");
        }

    }
}