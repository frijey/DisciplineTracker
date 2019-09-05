DROP procedure IF EXISTS `SListaIngresosPorCod_ingOPorFk_cod_fac`;
CREATE DEFINER=`root`@`%` PROCEDURE `SListaIngresosPorCod_ingOPorFk_cod_fac`(IN prm_parametro varchar(45))
BEGIN
SELECT 
ingresos.*
FROM
ingresos 
WHERE			
ingresos.cod_ing LIKE prm_parametro OR ingresos.fk_cod_fac LIKE prm_parametro ORDER BY fk_cod_fac;
END

DROP procedure IF EXISTS `SIngresos`;

CREATE DEFINER=`root`@`%` PROCEDURE `SIngresos`(IN prm_id int(11))
BEGIN
	SELECT 
		*
	FROM
		ingresos 
	WHERE			
		ingresos.cod_ing = prm_id;
END



CREATE DEFINER =`root`@`%` PROCEDURE `SentenciaIngresos`(accion varchar(5), prm_cod_ing int(11), prm_fk_cod_fac int(11), prm_mon_ing decimal(12,2), prm_fec_ing date, prm_hor_ing time, prm_tot_ing decimal(12,2), prm_bal_pen_ing decimal(12,2))
BEGIN

if (upper(accion) = "I") then

insert into ingresos(fk_cod_fac, mon_ing, fec_ing, hor_ing, tot_ing, bal_pen_ing) values(prm_fk_cod_fac, prm_mon_ing, prm_fec_ing, prm_hor_ing, prm_tot_ing, prm_bal_pen_ing);

elseif(upper(accion) = "U")then

update ingresos set fk_cod_fac = prm_fk_cod_fac, mon_ing = prm_mon_ing, fec_ing = prm_fec_ing, hor_ing = prm_hor_ing, tot_ing = prm_tot_ing, bal_pen_ing = prm_bal_pen_ing where cod_ing = prm_cod_ing;

elseif(upper(accion) = "D")then

delete from ingresos where cod_ing = prm_cod_ing;

end if;
select last_insert_id();

END