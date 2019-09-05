DROP procedure IF EXISTS `SListaRolPorCod_rolOPorDes_rol`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaRolPorCod_rolOPorDes_rol`(IN prm_parametro varchar(45))
BEGIN
SELECT 
rol.*
FROM
rol 
WHERE			
rol.cod_rol LIKE prm_parametro OR rol.des_rol LIKE prm_parametro ORDER BY des_rol;
END

DROP procedure IF EXISTS `SRol`;

CREATE DEFINER=`root`@`%` PROCEDURE `SRol`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		rol 
	WHERE			
		rol.cod_rol = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaRol`(accion varchar(5), prm_cod_rol int(11), prm_des_rol varchar(45))
BEGIN

if (upper(accion) = "I") then

insert into rol(des_rol) values(prm_des_rol);

elseif(upper(accion) = "U")then

update rol set des_rol = prm_des_rol where cod_rol = prm_cod_rol;

elseif(upper(accion) = "D")then

delete from rol where cod_rol = prm_cod_rol;

end if;
select last_insert_id();

END