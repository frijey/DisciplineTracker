DROP procedure IF EXISTS `SListaUsuarioPorCod_usuOPorNom_usu`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaUsuarioPorCod_usuOPorNom_usu`(IN prm_parametro varchar(45))
BEGIN
SELECT 
usuario.*
FROM
usuario 
WHERE			
usuario.cod_usu LIKE prm_parametro OR usuario.nom_usu LIKE prm_parametro ORDER BY nom_usu;
END

DROP procedure IF EXISTS `SUsuario`;

CREATE DEFINER=`root`@`%` PROCEDURE `SUsuario`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		usuario 
	WHERE			
		usuario.cod_usu = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaUsuario`(accion varchar(5), prm_cod_usu int(11), prm_nom_usu varchar(45), prm_cla_usu varchar(45), prm_tip_usu varchar(45), prm_ema_usu varchar(45), prm_fk_rol int(11))
BEGIN

if (upper(accion) = "I") then

insert into usuario(nom_usu, cla_usu, tip_usu, ema_usu, fk_rol) values(prm_nom_usu, prm_cla_usu, prm_tip_usu, prm_ema_usu, prm_fk_rol);

elseif(upper(accion) = "U")then

update usuario set nom_usu = prm_nom_usu, cla_usu = prm_cla_usu, tip_usu = prm_tip_usu, ema_usu = prm_ema_usu, fk_rol = prm_fk_rol where cod_usu = prm_cod_usu;

elseif(upper(accion) = "D")then

delete from usuario where cod_usu = prm_cod_usu;

end if;
select last_insert_id();

END