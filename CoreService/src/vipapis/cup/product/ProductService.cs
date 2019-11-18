using System;
using System.Collections.Generic;

namespace vipapis.cup.product{
	
	
	public interface ProductService {
		
		
		Dictionary<long?, com.vip.vop.cup.api.product.ConfirmProductAlterationResult> confirmProductAlteration( List<long?> message_ids_ );
		
		List<com.vip.vop.cup.api.product.Category> getProdCategory( string category_id_ );
		
		List<string> getProdSpuIdList( int? page_,   int? page_size_,   string create_start_time_,   string create_end_time_ );
		
		com.vip.vop.cup.api.product.SkuDetail getSkuDetail( string prod_sku_id_ );
		
		com.vip.vop.cup.api.product.SkuSalePrice getSkuSalePrice( string prod_sku_id_,   System.DateTime? effective_time_ );
		
		com.vip.vop.cup.api.product.SpuDetail getSpuDetail( string prod_spu_id_ );
		
		List<com.vip.vop.cup.api.product.Spu> getSpuInfoListByProdSpuIds( List<string> prod_spu_ids_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		List<com.vip.vop.cup.api.product.ProductAlteration> pullProductAlteration();
		
	}
	
}