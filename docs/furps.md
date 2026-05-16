# FURPS Quality Model for ChimneyWise

## Metadata
| Key               | Value                             |
|-------------------|-----------------------------------|
| Id                | FURPS                             |
| crossReference    | BC<br>RISK                        |

## Change log
| Version | Date       | Description              | Author     |
|---------|------------|--------------------------|------------|
| 0001    | 2026-05-16 | Initial                  | Jens Tirsvad Nielsen |

---

## FURPS Categories
### Functionality (F)
| ID         | Description                                   | Cross Reference |
|------------|-----------------------------------------------|-----------------|
| REQ-F-001  | The system shall support user authentication. | BC              |
| REQ-F-002  | The system shall support Danish, English, German, and French languages for all user-facing features and documentation. | BC              |
| REQ-F-003  | The system shall provide a solution structure following Clean Architecture principles, including src/ and tests/ folders. | BC              |

### Usability (U)
| ID         | Description                                   | Cross Reference |
|------------|-----------------------------------------------|-----------------|
| REQ-U-001  | The UI shall be intuitive and easy to use.    | BC              |

### Reliability (R)
| ID         | Description                                   | Cross Reference |
|------------|-----------------------------------------------|-----------------|
| REQ-R-001  | The system shall provide 99.9% uptime.        | RISK-001        |

### Performance (P)
| ID         | Description                                   | Cross Reference |
|------------|-----------------------------------------------|-----------------|
| REQ-P-001  | The system shall respond within 2 seconds.    | BC              |

### Supportability (S)
| ID         | Description                                   | Cross Reference |
|------------|-----------------------------------------------|-----------------|
| REQ-S-001  | The system shall provide detailed logs.       | RISK-002        |
| REQ-S-002  | The system shall provide comprehensive and up-to-date documentation for users and developers. | BC              |
| REQ-S-003  | The system shall support deployment and handover with scripts and guides for production readiness. | BC              |

### Design Constraints (+)
#### Security
| ID            | Description                                         | Cross Reference |
|---------------|-----------------------------------------------------|-----------------|
| REQ-SEC-001   | The system shall encrypt all sensitive data at rest. | RISK-003        |

#### Scalability
| ID            | Description                                         | Cross Reference |
|---------------|-----------------------------------------------------|-----------------|
| REQ-SCAL-001  | The system shall support 1000 concurrent users.     | BC              |

#### Interface
| ID            | Description                                         | Cross Reference |
|---------------|-----------------------------------------------------|-----------------|
| REQ-INT-001   | The system shall provide a RESTful API.             | BC              |

