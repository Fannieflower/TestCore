using System;
using System.Collections.Generic;

namespace com.vip.xstore.user.face.service{
	
	
	public interface XstoreCameraInfoService {
		
		
		int? batchDeleteCamera( com.vip.xstore.user.face.service.XstoreCameraBatchDelParam delParam_ );
		
		int? createCamera( com.vip.xstore.user.face.service.XstoreCameraInfoModel xstoreCameraInfoModel_ );
		
		int? deleteCamera( com.vip.xstore.user.face.service.XstoreCameraDelParam delParam_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.xstore.user.face.service.XstoreCameraInfoListResult queryCameraList( com.vip.xstore.user.face.service.XstoreCameraPageReqParam pageReqParam_ );
		
		com.vip.xstore.user.face.service.XstoreCameraStateLogListResult selectCameraStateLog( com.vip.xstore.user.face.service.XstoreCameraStateLogReqParam pageReqParam_ );
		
		int? updateCamera( com.vip.xstore.user.face.service.XstoreCameraUpdateParam updateParam_ );
		
		com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResult uploadCameraStateLog( com.vip.xstore.user.face.service.XstoreCameraStateLogParam xstoreCameraStateLogParam_ );
		
	}
	
}