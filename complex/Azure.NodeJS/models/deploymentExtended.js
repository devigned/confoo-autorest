/*
 * Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

var models = require('./index');

/**
 * @class
 * Initializes a new instance of the DeploymentExtended class.
 * @constructor
 * Deployment information.
 *
 * @member {string} [id] The ID of the deployment.
 * 
 * @member {string} name The name of the deployment.
 * 
 * @member {object} [properties] Deployment properties.
 * 
 * @member {string} [properties.provisioningState] The state of the
 * provisioning.
 * 
 * @member {string} [properties.correlationId] The correlation ID of the
 * deployment.
 * 
 * @member {date} [properties.timestamp] The timestamp of the template
 * deployment.
 * 
 * @member {object} [properties.outputs] Key/value pairs that represent
 * deploymentoutput.
 * 
 * @member {array} [properties.providers] The list of resource providers
 * needed for the deployment.
 * 
 * @member {array} [properties.dependencies] The list of deployment
 * dependencies.
 * 
 * @member {object} [properties.template] The template content. Use only one
 * of Template or TemplateLink.
 * 
 * @member {object} [properties.templateLink] The URI referencing the
 * template. Use only one of Template or TemplateLink.
 * 
 * @member {string} [properties.templateLink.uri] The URI of the template to
 * deploy.
 * 
 * @member {string} [properties.templateLink.contentVersion] If included, must
 * match the ContentVersion in the template.
 * 
 * @member {object} [properties.parameters] Deployment parameters. Use only
 * one of Parameters or ParametersLink.
 * 
 * @member {object} [properties.parametersLink] The URI referencing the
 * parameters. Use only one of Parameters or ParametersLink.
 * 
 * @member {string} [properties.parametersLink.uri] The URI of the parameters
 * file.
 * 
 * @member {string} [properties.parametersLink.contentVersion] If included,
 * must match the ContentVersion in the template.
 * 
 * @member {string} [properties.mode] The deployment mode. Possible values are
 * Incremental and Complete. Possible values include: 'Incremental',
 * 'Complete'
 * 
 * @member {object} [properties.debugSetting] The debug setting of the
 * deployment.
 * 
 * @member {string} [properties.debugSetting.detailLevel] Specifies the type
 * of information to log for debugging. The permitted values are none,
 * requestContent, responseContent, or both requestContent and
 * responseContent separated by a comma. The default is none. When setting
 * this value, carefully consider the type of information you are passing in
 * during deployment. By logging information about the request or response,
 * you could potentially expose sensitive data that is retrieved through the
 * deployment operations.
 * 
 */
function DeploymentExtended() {
}

/**
 * Defines the metadata of DeploymentExtended
 *
 * @returns {object} metadata of DeploymentExtended
 *
 */
DeploymentExtended.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'DeploymentExtended',
    type: {
      name: 'Composite',
      className: 'DeploymentExtended',
      modelProperties: {
        id: {
          required: false,
          serializedName: 'id',
          type: {
            name: 'String'
          }
        },
        name: {
          required: true,
          serializedName: 'name',
          type: {
            name: 'String'
          }
        },
        properties: {
          required: false,
          serializedName: 'properties',
          type: {
            name: 'Composite',
            className: 'DeploymentPropertiesExtended'
          }
        }
      }
    }
  };
};

module.exports = DeploymentExtended;