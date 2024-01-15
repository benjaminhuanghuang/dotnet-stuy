# Application logging

## Log levels
Trace (0)—Information related to the application’s internal activities and useful only for low-level debugging or system administration tasks. This log level is never used, because it can easily contain confidential data (such as configuration info, use of encryption keys, and other sensitive information that shouldn’t be viewed or recorded by anyone).

Debug (1)—Development-related information (variable values, stack trace, execution context, and so on) that’s useful for interactive analysis and debugging purposes. This log level should always be disabled in production environments, as the records might contain information that shouldn’t be disclosed.

Information (2)—Informative messages that describe events or activities related to the system’s normal behavior. This log level usually doesn’t contain sensitive or nondisclosable information, but it’s typically disabled in production to prevent excessive logging verboseness, which could result in big log files (or tables).

Warning (3)—Information about abnormal or unexpected behaviors, as well as any other event or activity that doesn’t alter the normal flow of the app.

Error (4)—Informative messages about noncritical events or activities that have likely halted, interrupted, or otherwise hindered the standard execution flow of a specific task or activity.

Critical (5)—Informative messages about critical events or activities that prevent the application from starting or that determine an irreversible and/or unrecoverable application crash.

None (6)—No information is logged. Typically, this level is used to disable logging.

## Logging configuration
appsettings.json
```json
"Logging": {
  "LogLevel": {
    "Default": "Information",
    "Microsoft.AspNetCore": "Warning",
    "MyBGList": "Debug"
  }
}
```

## Logging providers

## Application Insights logging provider
