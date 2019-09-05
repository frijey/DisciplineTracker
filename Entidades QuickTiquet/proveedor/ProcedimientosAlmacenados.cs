DROP procedure IF EXISTS `SListaProveedorPorCod_proOPorNom_pro`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaProveedorPorCod_proOPorNom_pro`(IN prm_parametro varchar(45))
BEGIN
SELECT 
proveedor.*
FROM
proveedor 
WHERE			
proveedor.cod_pro LIKE prm_parametro OR proveedor.nom_pro LIKE prm_parametro ORDER BY nom_pro;
END

DROP procedure IF EXISTS `SProveedor`;

CREATE DEFINER=`root`@`%` PROCEDURE `SProveedor`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		proveedor 
	WHERE			
		proveedor.cod_pro = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaProveedor`(accion varchar(5), prm_cod_pro int(11), prm_nom_pro varchar(45), prm_tip_pro varchar(45), prm_dir_pro varchar(245), prm_sec_pro varchar(45), prm_zon_pro varchar(45), prm_con_pro varchar(45), prm_ema_pro varchar(45), prm_rnc_pro varchar(15))
BEGIN

if (upper(accion) = "I") then

insert into proveedor(nom_pro, tip_pro, dir_pro, sec_pro, zon_pro, con_pro, ema_pro, rnc_pro) values(prm_nom_pro, prm_tip_pro, prm_dir_pro, prm_sec_pro, prm_zon_pro, prm_con_pro, prm_ema_pro, prm_rnc_pro);

elseif(upper(accion) = "U")then

update proveedor set nom_pro = prm_nom_pro, tip_pro = prm_tip_pro, dir_pro = prm_dir_pro, sec_pro = prm_sec_pro, zon_pro = prm_zon_pro, con_pro = prm_con_pro, ema_pro = prm_ema_pro, rnc_pro = prm_rnc_pro where cod_pro = prm_cod_pro;

elseif(upper(accion) = "D")then

delete from proveedor where cod_pro = prm_cod_pro;

end if;
select last_insert_id();

END