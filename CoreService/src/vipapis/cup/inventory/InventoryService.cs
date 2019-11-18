using System;
using System.Collections.Generic;

namespace vipapis.cup.inventory{
	
	
	public interface InventoryService {
		
		
		List<com.vip.vop.cup.api.inventory.ProdSkuInvInfo> getSkuInventory( string area_id_,   List<string> pro_sku_id_list_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.vop.cup.api.inventory.InventoryOpResult preHoldSkuInventory( string area_id_,   string order_sn_,   List<com.vip.vop.cup.api.inventory.ProdSkuInv> prod_sku_inv_list_ );
		
		com.vip.vop.cup.api.inventory.InventoryOpResult releaseSkuInventory( string order_sn_,   List<string> pro_sku_id_list_ );
		
	}
	
}