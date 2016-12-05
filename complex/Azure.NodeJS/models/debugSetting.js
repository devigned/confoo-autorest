/*
 * Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the DebugSetting class.
 * @constructor
 * @member {string} [detailLevel] Specifies the type of information to log for
 * debugging. The permitted values are none, requestContent, responseContent,
 * or both requestContent and responseContent separated by a comma. The
 * default is none. When setting this value, carefully consider the type of
 * information you are passing in during deployment. By logging information
 * about the request or response, you could potentially expose sensitive data
 * that is retrieved through the deployment operations.
 * 
 */
function DebugSetting() {
}

/**
 * Defines the metadata of DebugSetting
 *
 * @returns {object} metadata of DebugSetting
 *
 */
DebugSetting.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'DebugSetting',
    type: {
      name: 'Composite',
      className: 'DebugSetting',
      modelProperties: {
        detailLevel: {
          required: false,
          serializedName: 'detailLevel',
          type: {
            name: 'String'
          }
        }
      }
    }
  };
};

module.exports = DebugSetting;