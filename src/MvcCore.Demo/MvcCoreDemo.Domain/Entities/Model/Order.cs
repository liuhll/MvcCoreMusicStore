﻿using System;
using System.Collections.Generic;
using FluentValidation.Results;
using MvcCoreDemo.Domain.Interfaces.Validation;

namespace MvcCoreDemo.Domain.Entities.Model
{
    public class Order : AggregateRoot, ISelfValidation
    {
        public DateTime OrderDate { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public IList<OrderDetail> OrderDetails { get; set; }

        public ValidationResult ValidationResult { get; }
        public bool IsValid { get; }
    }
}
