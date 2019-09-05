DROP procedure IF EXISTS `SListaFacturaPorCod_facOPorFec_fac`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaFacturaPorCod_facOPorFec_fac`(IN prm_parametro varchar(45))
BEGIN
SELECT 
factura.*
FROM
factura 
WHERE			
factura.cod_fac LIKE prm_parametro OR factura.fec_fac LIKE prm_parametro ORDER BY fec_fac;
END

DROP procedure IF EXISTS `SFactura`;

CREATE DEFINER=`root`@`%` PROCEDURE `SFactura`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		factura 
	WHERE			
		factura.cod_fac = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaFactura`(accion varchar(5), prm_cod_fac int(11), prm_fec_fac date, prm_hor_fac time, prm_tip_fac varchar(45), prm_fk_cod_cli_fac int(11), prm_sub_tot_fac decimal(12,2), prm_itb_fac decimal(12,2), prm_des_fac decimal(12,2), prm_tot_fac decimal(12,2))
BEGIN

if (upper(accion) = "I") then

insert into factura(fec_fac, hor_fac, tip_fac, fk_cod_cli_fac, sub_tot_fac, itb_fac, des_fac, tot_fac) values(prm_fec_fac, prm_hor_fac, prm_tip_fac, prm_fk_cod_cli_fac, prm_sub_tot_fac, prm_itb_fac, prm_des_fac, prm_tot_fac);

elseif(upper(accion) = "U")then

update factura set fec_fac = prm_fec_fac, hor_fac = prm_hor_fac, tip_fac = prm_tip_fac, fk_cod_cli_fac = prm_fk_cod_cli_fac, sub_tot_fac = prm_sub_tot_fac, itb_fac = prm_itb_fac, des_fac = prm_des_fac, tot_fac = prm_tot_fac where cod_fac = prm_cod_fac;

elseif(upper(accion) = "D")then

delete from factura where cod_fac = prm_cod_fac;

end if;
select last_insert_id();

END