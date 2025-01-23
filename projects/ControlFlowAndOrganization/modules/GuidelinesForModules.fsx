// Guidelines for modules

(*

Every file requires a top-level module definition (or namespace).

The exceptions are:
    1 - If the project only consists of one file, the top-level module definition is optional.
    2 - If the file is the last compiled file for in a multi-file project.

Modules are not namespaces: they compile down to static .NET classes, where each member is a static.

The definition of a module is only allowed to be within a single file,
that is, not partial definitions across files.

*)
