using System;
using System.Collections.Generic;
using System.Text;
using HotChocolate.Types;

namespace HotChocolatePOC.Types
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Field(t => t.CreateAddress(default, default));
            //.Type<NonNullType<AddressType>>();
            //.Argument("member", a => a.Type<NonNullType<MemberInputType>>())
            //.Argument("address", a => a.Type<NonNullType<AddressInputType>>());
        }
    }
}
