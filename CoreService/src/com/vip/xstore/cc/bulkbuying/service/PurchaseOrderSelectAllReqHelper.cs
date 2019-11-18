using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class PurchaseOrderSelectAllReqHelper : TBeanSerializer<PurchaseOrderSelectAllReq>
	{
		
		public static PurchaseOrderSelectAllReqHelper OBJ = new PurchaseOrderSelectAllReqHelper();
		
		public static PurchaseOrderSelectAllReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PurchaseOrderSelectAllReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("purchaseType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetPurchaseType(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(PurchaseOrderSelectAllReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchaseType() != null) {
				
				oprot.WriteFieldBegin("purchaseType");
				oprot.WriteByte((byte)structs.GetPurchaseType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchaseType can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PurchaseOrderSelectAllReq bean){
			
			
		}
		
	}
	
}