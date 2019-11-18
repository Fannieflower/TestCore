using System;
using System.Collections.Generic;

namespace com.vip.adp.api.open.service{
	
	
	public interface UnionUrlService {
		
		
		com.vip.adp.api.open.service.UrlGenResponse genByGoodsId( List<string> goodsIdList_,   string chanTag_,   string requestId_ );
		
		com.vip.adp.api.open.service.UrlGenResponse genByGoodsIdWithOauth( List<string> goodsIdList_,   string chanTag_,   string requestId_ );
		
		com.vip.adp.api.open.service.UrlGenResponse genByVIPUrl( List<string> urlList_,   string chanTag_,   string requestId_ );
		
		com.vip.adp.api.open.service.UrlGenResponse genByVIPUrlWithOauth( List<string> urlList_,   string chanTag_,   string requestId_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.adp.api.open.service.VipLinkCheckResp vipLinkCheck( com.vip.adp.api.open.service.VipLinkCheckReq vipLinkCheckReq_ );
		
		com.vip.adp.api.open.service.VipLinkCheckResp vipLinkCheckWithOuth( com.vip.adp.api.open.service.VipLinkCheckReq vipLinkCheckReq_ );
		
	}
	
}