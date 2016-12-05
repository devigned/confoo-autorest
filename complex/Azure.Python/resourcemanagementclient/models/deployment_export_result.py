# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class DeploymentExportResult(Model):
    """The deployment export result. .

    :param template: The template content.
    :type template: object
    """ 

    _attribute_map = {
        'template': {'key': 'template', 'type': 'object'},
    }

    def __init__(self, template=None):
        self.template = template