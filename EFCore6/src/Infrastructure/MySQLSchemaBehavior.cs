﻿// Copyright (c) 2021, Oracle and/or its affiliates.
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License, version 2.0, as
// published by the Free Software Foundation.
//
// This program is also distributed with certain software (including
// but not limited to OpenSSL) that is licensed under separate terms,
// as designated in a particular file or component or in included license
// documentation.  The authors of MySQL hereby grant you an
// additional permission to link the program and your derivative works
// with the separately licensed software that they have included with
// MySQL.
//
// Without limiting anything contained in the foregoing, this file,
// which is part of MySQL Connector/NET, is also subject to the
// Universal FOSS Exception, version 1.0, a copy of which can be found at
// http://oss.oracle.com/licenses/universal-foss-exception.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License, version 2.0, for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

namespace MySql.EntityFrameworkCore.Infrastructure
{
  /// <summary>
  /// Translates the specified schema and object to an output object name whenever a schema is being used.
  /// </summary>
  /// <param name="schemaName">schema name</param>
  /// <param name="objectName">object name</param>
  /// <returns></returns>
  public delegate string MySQLSchemaNameTranslator(string schemaName, string objectName);

  /// <summary>
  /// Represents the behavior of the schema.
  /// </summary>
  public enum MySqlSchemaBehavior
  {
    /// <summary>
    /// Throws an exception if a schema is being used. All specified translator delegates are ignored.
    /// This is the default.
    /// </summary>
    Throw,
    /// <summary>
    /// Silently ignores any schema definitions. All specified translator delegates are ignored.
    /// </summary>
    Ignore,
    /// <summary>
    /// Uses the specified translator delegate to translate an input schema and object name to
    /// an output object name whenever a schema is being used.
    /// </summary>
    Translate
  }
}
