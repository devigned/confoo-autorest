# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class AliasType(Model):
    """The alias type. .

    :param name: The alias name.
    :type name: str
    :param paths: The paths for an alias.
    :type paths: list of :class:`AliasPathType <Azure.models.AliasPathType>`
    """ 

    _attribute_map = {
        'name': {'key': 'name', 'type': 'str'},
        'paths': {'key': 'paths', 'type': '[AliasPathType]'},
    }

    def __init__(self, name=None, paths=None):
        self.name = name
        self.paths = paths