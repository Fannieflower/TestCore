using System;
using System.Collections.Generic;

namespace vipapis.xstore.cc.rfid.api{
	
	
	public interface RFIDService {
		
		
		vipapis.xstore.cc.rfid.api.RfidDataResponse addRfid2BarcodeMapping( vipapis.xstore.cc.rfid.api.RfidDataRequest request_ );
		
		List<vipapis.xstore.cc.rfid.api.RfidDataResponse> batchAddRfid2BarcodeMapping( List<vipapis.xstore.cc.rfid.api.RfidDataRequest> requests_ );
		
		string generateExternalCode( string barcode_,   string owner_,   string oldBarcode_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		string queryBarcodeByExternalCode( string externalCode_,   string owner_ );
		
		string queryBarcodeByRfid( string rfid_,   string owner_ );
		
		vipapis.xstore.cc.rfid.api.RfidEpcStatusResponse queryEpcStatus( string epc_,   string owner_ );
		
		List<vipapis.xstore.cc.rfid.api.RfidSyncResultResponse> queryRfidSyncResult( List<string> barcodes_,   string owner_ );
		
		bool? uploadEpc( vipapis.xstore.cc.rfid.api.RfidEpcParamModel epc_ );
		
	}
	
}