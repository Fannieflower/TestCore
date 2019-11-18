using System;
using System.Collections.Generic;

namespace com.vip.adp.api.open.service{
	
	
	public interface UnionGoodsService {
		
		
		List<com.vip.adp.api.open.service.GoodsInfo> getByGoodsIds( List<string> goodsIdList_,   string requestId_ );
		
		List<com.vip.adp.api.open.service.GoodsInfo> getByGoodsIdsWithOauth( List<string> goodsIdList_,   string requestId_ );
		
		com.vip.adp.api.open.service.GoodsInfoResponse goodsList( com.vip.adp.api.open.service.GoodsInfoRequest request_ );
		
		com.vip.adp.api.open.service.GoodsInfoResponse goodsListWithOauth( com.vip.adp.api.open.service.GoodsInfoRequest request_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.adp.api.open.service.GoodsInfoResponse query( com.vip.adp.api.open.service.QueryGoodsRequest request_ );
		
		com.vip.adp.api.open.service.GoodsInfoResponse queryWithOauth( com.vip.adp.api.open.service.QueryGoodsRequest request_ );
		
	}
	
}