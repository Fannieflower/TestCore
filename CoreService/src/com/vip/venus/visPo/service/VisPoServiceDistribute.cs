using System;
using System.Collections.Generic;

namespace com.vip.venus.visPo.service{
	
	
	public interface VisPoServiceDistribute {
		
		
		void dispatchNoParameter();
		
		List<com.vip.venus.visPo.service.PoDetailData> getPoDataByMaxId( long maxId_,   long count_,   string warehouseCode_ );
		
		List<com.vip.venus.visPo.service.WMSPoDetail> getPoDetailsWMSByPoNoAndItemNo( Dictionary<string, List<string>> queryParams_ );
		
		List<com.vip.venus.visPo.service.EBSPoDetail> getPoEBSDetailsByPo( string po_,   int page_,   int size_ );
		
		List<com.vip.venus.visPo.service.EBSPoDetail> getPoEBSDetailsByPoBatchNum( string po_,   int batchNum_,   int page_,   int size_ );
		
		com.vip.venus.visPo.service.EBSPoDetail getPoEBSDetailsByPoSKU( string poNum_,   string itemNum_ );
		
		string getPoWMSDetailsByMaxId( string maxId_,   string saleArea_,   int count_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}