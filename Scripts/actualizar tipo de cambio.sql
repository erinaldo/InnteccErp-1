update compras.cpcompra
	set tipocambio = 0;

update compras.cpcompra
	set tipocambio = a.valorventaventa
    	from inntecc.tipocambio a
        	where 	cpcompra.fechaemision = a.fechatipocambio
            		and cpcompra.idtipomoneda = 2 and tipocambio = 0;

select DISTINCT fechaemision from compras.cpcompra where cpcompra.idtipomoneda = 2 and cpcompra.tipocambio = 0;