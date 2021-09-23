# ef6-effort-bug
Example project illustrating the type mismatch issue

This is a really lightweight unit test / ef6 database

Occassionally, running the unit test suite inside visual studio will create an exception such as:

```
G2T2 (a2b2005f-930d-4340-852a-2aab93b180a4)
   Source: TestGroup1.cs line 101
   Duration: 109 ms

  Message: 
Initialization method Tests.Domain2.SetUp threw exception. System.Data.Entity.Infrastructure.DbUpdateException: An error occurred while updating the entries. See the inner exception for details. ---> System.Data.Entity.Core.UpdateException: An error occurred while updating the entries. See the inner exception for details. ---> System.ArgumentException: Object of type 'dbo_Garplies' cannot be converted to type 'dbo_Bars'..

  Stack Trace: 
RuntimeType.TryChangeType(Object value, Binder binder, CultureInfo culture, Boolean needsSpecialCast)
RuntimeType.CheckValue(Object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr)
MethodBase.CheckArguments(Object[] parameters, Binder binder, BindingFlags invokeAttr, CultureInfo culture, Signature sig)
RuntimeMethodInfo.InvokeArgumentsCheck(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
DatabaseReflectionHelper.InsertEntity(ITable table, Object entity, Transaction transaction)
InsertCommandAction.ExecuteNonQuery(ActionContext context)
EffortEntityCommand.ExecuteNonQuery()
DbCommandDispatcher.<NonQuery>b__0(DbCommand t, DbCommandInterceptionContext`1 c)
InternalDispatcher`1.Dispatch[TTarget,TInterceptionContext,TResult](TTarget target, Func`3 operation, TInterceptionContext interceptionContext, Action`3 executing, Action`3 executed)
<13 more frames...>
DefaultExecutionStrategy.Execute[TResult](Func`1 operation)
ObjectContext.SaveChangesInternal(SaveOptions options, Boolean executeInExistingTransaction)
ObjectContext.SaveChanges(SaveOptions options)
InternalContext.SaveChanges()
--- End of inner exception stack trace ---
InternalContext.SaveChanges()
LazyInternalContext.SaveChanges()
DbContext.SaveChanges()
BaseUnitTest.SeedData() line 34
Domain2.SetUp() line 88

  (result has additional output)

   Open test log

```
