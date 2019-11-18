using System;
using System.Collections.Generic;

namespace com.vip.vop.cup.api.oto{
	
	
	public interface OtoProductService {
		
		
		List<com.vip.vop.cup.api.oto.SkuHealthCheck> batchGetSkuHealthCheck( List<long?> v_sku_ids_ );
		
		List<com.vip.vop.cup.api.oto.SpuHealthCheck> batchGetSpuHealthCheck( List<long?> v_spu_ids_ );
		
		com.vip.vop.cup.api.product.SkuDetail getSkuDetail( long v_sku_id_,   string owner_ );
		
		com.vip.vop.cup.api.product.SpuDetail getSpuDetail( long v_spu_id_,   string owner_ );
		
		List<com.vip.vop.cup.api.oto.SpuIdAndSkuId> getSpuIdAndSkuId( List<com.vip.vop.cup.api.oto.VendorIdAndBarcode> list_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}