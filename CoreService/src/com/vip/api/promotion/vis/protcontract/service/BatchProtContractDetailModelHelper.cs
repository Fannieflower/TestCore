using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class BatchProtContractDetailModelHelper : TBeanSerializer<BatchProtContractDetailModel>
	{
		
		public static BatchProtContractDetailModelHelper OBJ = new BatchProtContractDetailModelHelper();
		
		public static BatchProtContractDetailModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BatchProtContractDetailModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mainInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel();
						com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModelHelper.getInstance().Read(value, iprot);
						
						structs.SetMainInfo(value);
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
		
		
		public void Write(BatchProtContractDetailModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMainInfo() != null) {
				
				oprot.WriteFieldBegin("mainInfo");
				
				com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModelHelper.getInstance().Write(structs.GetMainInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BatchProtContractDetailModel bean){
			
			
		}
		
	}
	
}