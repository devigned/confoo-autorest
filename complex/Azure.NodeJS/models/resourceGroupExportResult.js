/*
 * Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

var models = require('./index');

/**
 * @class
 * Initializes a new instance of the ResourceGroupExportResult class.
 * @constructor
 * @member {object} [template] The template content.
 * 
 * @member {object} [error] The error.
 * 
 * @member {string} [error.code] The error code returned when exporting the
 * template.
 * 
 * @member {string} [error.message] The error message describing the export
 * error.
 * 
 * @member {string} [error.target] The target of the error.
 * 
 * @member {array} [error.details] Validation error.
 * 
 */
function ResourceGroupExportResult() {
}

/**
 * Defines the metadata of ResourceGroupExportResult
 *
 * @returns {object} metadata of ResourceGroupExportResult
 *
 */
ResourceGroupExportResult.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'ResourceGroupExportResult',
    type: {
      name: 'Composite',
      className: 'ResourceGroupExportResult',
      modelProperties: {
        template: {
          required: false,
          serializedName: 'template',
          type: {
            name: 'Object'
          }
        },
        error: {
          required: false,
          serializedName: 'error',
          type: {
            name: 'Composite',
            className: 'ResourceManagementErrorWithDetails'
          }
        }
      }
    }
  };
};

module.exports = ResourceGroupExportResult;