---
title: "ADR-0001: Language Selection - C# vs C++"
status: "Accepted"
date: "2026-05-16"
authors: "Jens Tirsvad Nielsen (Approver)"
tags: ["architecture", "decision"]
supersedes: ""
superseded_by: ""
---

# ADR-0001: Language Selection - C# vs C++

## Status

**Accepted**

## Context

The project requires a modern, maintainable, and efficient software solution for chimney design and construction. The team must select a primary programming language that supports rapid development, is well-suited for Windows environments, and aligns with the team's expertise and customer expectations for timely delivery.

## Decision

We will use C# as the primary programming language for the project. C# offers a productive development environment, strong tooling support on Windows, and aligns with the team's existing skills, enabling faster delivery and easier long-term maintenance.

## Consequences

### Positive

- **ADR-0001-POS-001**: Accelerated development due to high-level abstractions and rich libraries in C#
- **ADR-0001-POS-002**: Improved maintainability and readability for future enhancements
- **ADR-0001-POS-003**: Seamless integration with Windows ecosystem and .NET tooling

### Negative

- **ADR-0001-NEG-001**: Potentially less control over low-level system resources compared to C++
- **ADR-0001-NEG-002**: May not be optimal for performance-critical, low-level operations
- **ADR-0001-NEG-003**: Portability to non-Windows platforms may require additional effort

## Alternatives Considered

### C++

- **ADR-0001-ALT-001**: **Description**: Use C++ for core application logic and UI
- **ADR-0001-ALT-002**: **Rejection Reason**: Steeper learning curve, slower development speed, and increased complexity for Windows desktop applications. The team has more experience with C#, enabling faster delivery and easier onboarding.

## Implementation Notes

- **ADR-0001-IMP-001**: Leverage .NET ecosystem and Visual Studio for development
- **ADR-0001-IMP-002**: Ensure codebase follows Clean Architecture principles for maintainability
- **ADR-0001-IMP-003**: Monitor for any performance bottlenecks that may require native interop
- **ADR-0001-IMP-004**: Future code optimizations can be implemented in C++/C and integrated via interop if performance-critical sections are identified

## References

- **ADR-0001-REF-001**: [.NET Documentation](https://docs.microsoft.com/dotnet/)
- **ADR-0001-REF-002**: [C# vs C++ for Windows Development](https://learn.microsoft.com/en-us/dotnet/standard/choosing-core-framework-server)
- **ADR-0001-REF-003**: [Clean Architecture](https://8thlight.com/blog/uncle-bob/2012/08/13/the-clean-architecture.html)
