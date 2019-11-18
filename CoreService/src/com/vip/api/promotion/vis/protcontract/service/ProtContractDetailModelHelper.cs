using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractDetailModelHelper : TBeanSerializer<ProtContractDetailModel>
	{
		
		public static ProtContractDetailModelHelper OBJ = new ProtContractDetailModelHelper();
		
		public static ProtContractDetailModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractDetailModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("discountInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.DiscountInfoModel value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.DiscountInfoModel();
						com.vip.api.promotion.vis.protcontract.service.DiscountInfoModelHelper.getInstance().Read(value, iprot);
						
						structs.SetDiscountInfo(value);
					}
					
					
					
					
					
					if ("auditingLogList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModel> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModel elem2;
								
								elem2 = new com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModel();
								com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModelHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAuditingLogList(value);
					}
					
					
					
					
					
					if ("discountList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel elem4;
								
								elem4 = new com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel();
								com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModelHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDiscountList(value);
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
		
		
		public void Write(ProtContractDetailModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMainInfo() != null) {
				
				oprot.WriteFieldBegin("mainInfo");
				
				com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModelHelper.getInstance().Write(structs.GetMainInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountInfo() != null) {
				
				oprot.WriteFieldBegin("discountInfo");
				
				com.vip.api.promotion.vis.protcontract.service.DiscountInfoModelHelper.getInstance().Write(structs.GetDiscountInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAuditingLogList() != null) {
				
				oprot.WriteFieldBegin("auditingLogList");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModel _item0 in structs.GetAuditingLogList()){
					
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractAuditingLogModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountList() != null) {
				
				oprot.WriteFieldBegin("discountList");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModel _item0 in structs.GetDiscountList()){
					
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractDetailModel bean){
			
			
		}
		
	}
	
}