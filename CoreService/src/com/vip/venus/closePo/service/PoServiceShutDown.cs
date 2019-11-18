using System;
using System.Collections.Generic;

namespace com.vip.venus.closePo.service{
	
	
	public interface PoServiceShutDown {
		
		
		com.vip.venus.closePo.service.PoGoodReceiveInfoResult getGoodReceiveInfoByPo( com.vip.venus.closePo.service.PoGoodReceiveInfoParam param_ );
		
		List<com.vip.venus.closePo.service.PoCloseForWmsReturn> getPoCloseForWms( com.vip.venus.closePo.service.PoCloseForWmsParam param_ );
		
		List<com.vip.venus.closePo.service.PoCloseMsg> getPoCloseListByWarehouseCode( long maxId_,   long count_,   string warehouseCode_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		string shutDownPo( com.vip.venus.closePo.service.ShutDownPoParam param_ );
		
		string timedTasks();
		
	}
	
}